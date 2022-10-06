from django.contrib import admin

from shorapp.models import *

# Register your models here.

admin.register(Product)
admin.register(MyOrder)
admin.register(ProductMyOrder)