from django import forms
from django.core.validators import MinLengthValidator


class LoginForm(forms.Form):
    login = forms.CharField(label='Login: ', max_length=100)
    password = forms.CharField(label='Hasło: ',
                               max_length=128,
                               widget=forms.PasswordInput(),
                               validators=[MinLengthValidator(limit_value=3)])
