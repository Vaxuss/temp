from django.urls import path

from multi_lang.views import hello

urlpatterns = [
    path('hello/', hello)
]