"""Django_project URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/4.1/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.contrib.auth import login
from django.urls import path, include

from gadugadu_app.views import *
from games_app.views import *
from first_app.views import *
from library_app.views import *
from shorapp.views import *


urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include("first_app.urls")),
    path('', include("games_app.urls")),
    path('lib/', include("library_app.urls")),
    path('wiadomosc/', wiadomosc),
    path('gg/form', ShowFormView.as_view()),
    path('football', ShowFormView.as_view()),
    path('rpg/', include("rpg_app.urls"))
]
