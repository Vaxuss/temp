from django import forms
from django.core.validators import MinLengthValidator


class GameForms(forms.Form):
    host = forms.ChoiceField(choices= GameForms.host.all())
    host_score = forms.IntegerField(label='Wynik Gospodarzy: ')
    guest_score = forms.IntegerField(label='Wynik Gości: ')
    guest = forms.Select(label='Drużyna Gospodarzy: ')
