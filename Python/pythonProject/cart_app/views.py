from django.http import HttpResponse
from django.shortcuts import render
from django.views import View

from cart_app.forms import CartForm


class Add_cart(View):
    def get(self, request):
        form = CartForm()
        return render(request, 'cart_app/templates/cart_app/cart.html', {'form':form})
    def post(self, request):
        form = CartForm(request.POST)
        if form.is_valid():
            response = request.session['wozek'] = form
            return HttpResponse(response)
        else:
            pass

def show_cart(request):
    return request