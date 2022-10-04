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
from django.urls import path

from first_app.views import hello, hello_name, add, multiply, bros, fibb, game, hellopath, article, greetings, calc, \
    rand_gen, index, form, fizz_buzz, rpg, list_comment, main

urlpatterns = [
    path('admin/', admin.site.urls),
    path('article/<int:id>', article),
    path('greetings/<str:name>/<int:repeat>', greetings),
    path('rand_gen/<int:min>/<int:max>', rand_gen),
    path('rand_gen/<int:min>/<int:max>/<int:throw>', rand_gen),
    path('calc/<int:number_a>/<str:operation>/<int:number_b>', calc),
    path('', index),
    path('form/', form),
    path('fizzbum/<int:n>', fizz_buzz),
    #path('hellopath/<str:name>', hellopath),
    path('multiply/<int:n>', multiply),
    path('rpg/', rpg),
    path('fake_comments/', list_comment),
    path('main/', main),

]
