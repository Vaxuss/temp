from django.urls import path

from users_app.views import *

urlpatterns = [
    path('create_test/', create_user),
    path('login/', LoginView.as_view()),
    path('data/', ImportantDataView.as_view()),
    path('logout/', make_logout),
    path('register/', RegisterView.as_view()),
    path('secret_view/', SecretView.as_view()),
]