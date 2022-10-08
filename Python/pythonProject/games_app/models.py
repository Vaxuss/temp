from django.db import models

class Game(models.Model):
    name = models.CharField(max_length=128)
    description = models.TextField()
    rating = models.IntegerField()
    price = models.DecimalField(max_digits=6, decimal_places=2)
    platform = models.ForeignKey('Platform', on_delete=models.CASCADE, null=True, blank=True)
    category = models.ManyToManyField('Category', blank=True, null=True)

    def __str__(self):
        return f"{self.name} { self.description} {self.rating} {self.price}"


class Platform(models.Model):
    name = models.CharField(max_length=256)
    url = models.CharField(max_length=512)
    description = models.TextField()
    def __str__(self):
        return f"{self.name} {self.url} { self.description}"

class Category(models.Model):
    name = models.CharField(max_length=256)

    def __str__(self):
        return f"{self.name}"

class GameDetails(models.Model):
    cheat_codes = models.CharField(max_length=512)
    finished = models.BooleanField()
    play_time = models.DurationField()
    game = models.OneToOneField(Game, on_delete = models.CASCADE, blank=True, null=True)

    def __str__(self):
        return f"kody:{self.cheat_codes}, ukończono:{self.finished}, czas gry:{ self.play_time}, gra: {self.game}"

