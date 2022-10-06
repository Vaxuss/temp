from django.urls import path

from library_app.views import *

urlpatterns = [
    path('add/', AddBookView.as_view()),
    path('', BookShow),
    path('edit/<int:n>', EditBookView.as_view()),
]