from django.urls import path

from session_app.views import *

urlpatterns = [
path('counter/', counter)
]