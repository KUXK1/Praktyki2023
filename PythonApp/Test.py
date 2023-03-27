import pygame
pygame.init()
W = 1920
Hi = 1080
White=(255,255,255)
Black=(0,0,0)
win = pygame.display.set_mode((W, Hi),pygame.FULLSCREEN)
font1 = pygame.font.Font(None, 300)
text1 = font1.render("Pożar",True, White)
win.fill(Black)
text_rect1 = text1.get_rect(center=(W/2, Hi/2))
win.blit(text1, text_rect1)
while True:
    pygame.display.update()
