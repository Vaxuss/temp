from django.contrib.auth.models import User
from django.db import models
from django.utils.regex_helper import Choice


# Create your models here.

class Player(models.Model):
    user = models.OneToOneField(User , on_delete= models.CASCADE)
    location = models.ForeignKey('Location', on_delete= models.CASCADE)

class Location(models.Model):
    name = models.CharField(max_length=255)
    description = models.CharField(max_length=255)


class Choices(models.Model):
    starting_location = models.ForeignKey(Location , on_delete= models.CASCADE ,related_name="starting_location")
    ending_location = models.ForeignKey(Location , on_delete= models.CASCADE ,related_name="ending_location")
    description = models.CharField(max_length=255)