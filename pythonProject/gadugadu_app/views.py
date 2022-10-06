from django.http import HttpResponse
from django.shortcuts import render
from django.views import View

from gadugadu_app.forms import LoginForm
from gadugadu_app.models import *


# Create your views here.



class ShowFormView(View):
    def get(self, request):
        form = LoginForm()
        return render(request, 'loginform.html', context={'form':form})
    def post(self, request):
        form = LoginForm(request.POST)
        if form.is_valid():
            login = form.cleaned_data.get("login")
            password = form.cleaned_data.get("password")
            return HttpResponse(f"ok {login} twoje haslo {password}")
        else:
            return render(request, 'loginform.html', context={'form':form})


def wiadomosc(request):
    mess = Message.objects.all()
    return render(request, 'wiadomosci.html', context={'mess':mess})