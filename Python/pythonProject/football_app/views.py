from django.shortcuts import render, redirect
from django.views import View

from football_app.forms import GameForms
from football_app.models import Game


# Create your views here.

class Football_Game_Add(View):
    def get(self, request):
        form = GameForms()
        return render(request, 'templates/football.html', {'form':form})

    def post(self, request):
        form = GameForms(request.POST, instance=Game())
        if form.is_valid():
            form.save()
            return redirect("/football")
        else:
            return render(request, 'templates/football.html', {'form': form})

def football(request):
    form = GameForms()
    return render(request, 'templates/football.html', context={'form':form})