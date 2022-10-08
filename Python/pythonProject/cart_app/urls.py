from django.urls import path

from cart_app.views import *

urlpatterns = [
path('add/', Add_cart.as_view()),
path('', show_cart),
]