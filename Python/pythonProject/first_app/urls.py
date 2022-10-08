from django.urls import path

from first_app.views import *

urlpatterns = [
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
    path('login/', login_user),
    path('add_product/', add_product),
    path('show_product/', show_products),
    path('view/', FormView.as_view()),#t.as_view() - zawsze dla klas
    path('pizza/', PizzaView.as_view()),
    path('car/', CarView.as_view()),
    path('login_view/', LoginView.as_view()),
]