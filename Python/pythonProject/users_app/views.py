from django.contrib.auth import authenticate, login, logout
from django.contrib.auth.decorators import login_required
from django.contrib.auth.mixins import LoginRequiredMixin
from django.contrib.auth.models import User
from django.http import HttpResponse
from django.shortcuts import render
from django.views import View

from users_app.forms import LoginForm, RegisterForm


def create_user(request):
    user = User.objects.create_user(username='test',
                                    email='test@test.pl',
                                    password='zaq1@WSX')
    return HttpResponse(f'OK! {user.pk}')


class LoginView(View):
    def get(self, request):
        message = "Zaloguj"
        form = LoginForm()
        return render(request, 'user_app/templates/user_app/form.html', context={'form': form, 'message': message})

    def post(self, request):
        form = LoginForm(request.POST)
        message = "Zaloguj"
        if form.is_valid():
            user = authenticate(username=form.cleaned_data.get('username'),
                                password=form.cleaned_data.get('password'))
            if user is not None:
                login(request, user)
                return HttpResponse('OK! Autentyfikacja potwierdzona')
            else:
                return HttpResponse('Nie ma cie w naszej bazie')
        else:
            return render(request, 'user_app/templates/user_app/form.html', context={'form': form, 'message': message})


class ImportantDataView(View):
    def get(self, request):
        if request.user.is_authenticated:
            return HttpResponse('Najlepsze kasztany są na placu Pigal')
        else:
            return HttpResponse('Tajne dane! Tylko dla zalogwanych!')


def make_logout(request):
    logout(request)
    return HttpResponse("poprawne wylogowanie")


class RegisterView(View):
    def get(self, request):
        message = "Zarejestruj"
        form = RegisterForm()
        return render(request, 'user_app/templates/user_app/form.html', context={'form': form, 'message': message})

    def post(self, request):
        message = "Zarejestruj"
        form = RegisterForm(request.POST)
        if form.is_valid():
            user = User.objects.create_user(username=form.cleaned_data.get("username"),
                                            email=form.cleaned_data.get("email"),
                                            password=form.cleaned_data.get("password"))
            return HttpResponse("poprawna rejestracja")
        else:
            return render(request, 'user_app/templates/user_app/form.html', context={'form': form, 'message': message})


@login_required
def secret_data(request):
    return HttpResponse('Tajne dane tylko dla zalogowanych')


class SecretView(LoginRequiredMixin, View):
    def get(self, request):
        return HttpResponse('Tajne dane z klasy widoku tylko dla zalogowanych')
