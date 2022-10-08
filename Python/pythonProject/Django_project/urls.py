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
from django.urls import path, include

from football_app import *
from gadugadu_app import *
from games_app.views import *
from first_app import *
from library_app.views import *


urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include("first_app.urls")),
    path('', include("games_app.urls")),
    path('cookie/', include("cookie_app.urls")),
    path('session/', include("session_app.urls")),
    path('cart/', include("cart_app.urls")),
    path('lib/', include("library_app.urls")),
    path('music/', include("generic_music_app.urls")),
    path('user/', include("users_app.urls")),
    path('lang/', include("multi_lang.urls")),
]
