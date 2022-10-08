from django import forms

from football_app.models import Game


class GameForms(forms.ModelForm):
    class Meta:
        model = Game
        fields = '__all__'