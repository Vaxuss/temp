from django.urls import path

from giera.views import *

urlpatterns = [
path('locations', show_location)
]