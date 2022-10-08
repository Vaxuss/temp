from django.urls import path

from generic_music_app.views import *

urlpatterns = [
    path('', SongListView.as_view()),
    path('details/<int:pk>/', SongDetailView.as_view()),
    path('add/', SongCreateView.as_view()),
    path('add/artist/', ArtistCreateView.as_view()),
    path('show/artists/', ArtistListView.as_view()),
    path('edit/<int:pk>/', SongUpdateView.as_view()),
    path('edit/artist/<int:pk>/', ArtistUpdateView.as_view()),
    path('del/<int:pk>/', SongDeleteView.as_view()),
    path('del/artist/<int:pk>/', ArtistDeleteView.as_view()),
]