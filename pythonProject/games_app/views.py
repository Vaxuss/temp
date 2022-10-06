from django.shortcuts import render, redirect
from django.http import HttpResponse
from django.views import View
from django.shortcuts import render
from games_app.models import*

import games_app.models


def game_list(request):
    games = Game.objects.all()
    return render(request, 'game.html', context={'games':games})

def game_show(request, n):
    gameToShow = Game.objects.get(pk = n)
    return render(request, 'show_game.html', context={'game':gameToShow})

def game_edit(request, n):
    if request.method == 'GET':
        gameToEdit = Game.objects.get(pk = n)
        platform = Platform.objects.all()
        return render(request, 'game_edit.html', context={'game':gameToEdit, 'platform':platform})
    if request.method == 'POST':
        gameToEdit = Game.objects.get(pk=n)
        gameToEdit.name = request.POST.get('nazwa', '')
        gameToEdit.description = request.POST.get('opis', '')
        platforma_nazwa = request.POST.get('platforma', '')
        platforma = Platform.objects.get(name=platforma_nazwa)
        gameToEdit.platform=platforma
        gameToEdit.rating = request.POST.get('ocena', '')
        gameToEdit.price = request.POST.get('cena', '')
        gameToEdit.save()
        games = Game.objects.all()
        return render(request, 'game.html', context={'games': games})

class Game_add(View):
    def get(self, request):
        platform = Platform.objects.all()
        return render(request, 'game_add.html', context={'platform':platform})
    def post(self, request):
        platforma_nazwa = request.POST.get('platforma', '')
        platforma = Platform.objects.get(name=platforma_nazwa)
        gameToCreate = Game.objects.create(name = request.POST.get('nazwa', ''),
                                           description = request.POST.get('opis', ''),
                                           platform = platforma,
                                           rating = request.POST.get('ocena', ''),
                                           price = request.POST.get('cena', ''))
        games = Game.objects.all()
        return render(request, 'game.html', context={'games': games})

def game_del(request, n):
    gameToDel = Game.objects.get(pk=n)
    message = "Czy napewno chcesz usunąć: " + gameToDel.name + "?"
    return render(request, 'game_del.html', context={'game': gameToDel, 'message':message})

def delete_Game(request, n):
    gameToDel = Game.objects.get(pk=n)
    gameToDel.delete()
    games = Game.objects.all()
    return render(request, 'game.html', context={'games':games})

def platform_show(request, n):
    platformToShow = Platform.objects.get(name = n)
    platformGames = platformToShow.game_set.all()
    return render(request, 'platform_show.html', context={'platform': platformToShow, 'games':platformGames})