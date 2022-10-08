from django.db import models

class Cart(models.Model):
    chleb = models.BooleanField(default=False)
    woda = models.BooleanField(default=False)
    maslo = models.BooleanField(default=False)
    szynka = models.BooleanField(default=False)

    def __str__(self):
        return f'Chleb: {self.chleb} Woda: {self.woda} Masło: {self.maslo} Szynka: {self.szynka}'
