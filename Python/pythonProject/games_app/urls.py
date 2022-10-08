from django.urls import path

from games_app.views import *

urlpatterns = [
    path('game/', game_list),
    path('game/show/<int:n>', game_show),
    path('game/edit/<int:n>', game_edit),
    path('game/add/', Game_add.as_view()),
    path('game/del/<int:n>', game_del),
    path('game/delete/<int:n>', delete_Game),
    path('game/platform/<str:n>', platform_show)

]