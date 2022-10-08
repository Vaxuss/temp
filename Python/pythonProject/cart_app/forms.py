from django import forms

from cart_app.models import Cart


class CartForm(forms.ModelForm):
    class Meta:
        model = Cart
        fields = '__all__'#['title','author']