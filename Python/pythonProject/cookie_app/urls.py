from django.urls import path

from cookie_app.views import *

urlpatterns = [
    path('test/', test_cookie),
    path('add/', Cookie_add.as_view()),
    path('del/<str:key>', cookie_del),
    path('show/', show_cookie),
]