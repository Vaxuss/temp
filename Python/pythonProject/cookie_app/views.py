from django.http import HttpResponse
from django.shortcuts import render
from django.views import View


# Create your views here.

def test_cookie(requset):
    response = HttpResponse('Ciasteczko założone')
    response.set_cookie('test_cookie', 'test')
    return response

def show_cookie(request):
    cookies = request.COOKIES
    return render(request, 'cookie_app/templates/cookie_app/cookie_show.html', context={'cookies':cookies})

class Cookie_add(View):
    def get(self, request):
        message = 'dodaj ciastko'
        return render(request, 'cookie_app/templates/cookie_app/cookie.html', context={'message':message})

    def post(self, request):
        key = request.POST.get('key', '')
        val = request.POST.get('val', '')
        response = render(request, 'cookie_app/templates/cookie_app/cookie_added.html')
        response.set_cookie(key, val)
        return response

def cookie_del(request, key):
    response = HttpResponse("Usunięto " + key + " ciasteczko")
    response.delete_cookie(key)
    return response