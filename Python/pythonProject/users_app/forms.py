from django import forms


class LoginForm(forms.Form):
    username = forms.CharField(max_length=128)
    password = forms.CharField(max_length=256, widget=forms.PasswordInput())


class RegisterForm(forms.Form):
    username = forms.CharField(max_length=128)
    email = forms.EmailField(max_length=256)
    password = forms.CharField(max_length=256, widget=forms.PasswordInput())
