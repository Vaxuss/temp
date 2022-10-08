from django.contrib import admin

from games_app.models import *

# Register your models here.

admin.site.register(Game)
admin.site.register(Platform)
admin.site.register(Category)
admin.site.register(GameDetails)
