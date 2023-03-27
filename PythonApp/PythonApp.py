import can
import pygame
pygame.init()
W = 1920
Hi = 1080
win = pygame.display.set_mode((W, Hi),pygame.FULLSCREEN)
font1 = pygame.font.Font(None, 300)
font2 = pygame.font.Font(None, 200)
white=(255,255,255)
black=(0,0,0)
test=1
x=1
y=2
z=3
import time
bus = can.Bus(interface='socketcan', channel='can0', bitrate=125000)
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            quit()
    msg = can_bus.recv()
    
    if msg.arbitration_id == 0x123:
        S = msg.Date[0]
        M = msg.Date[1]
        H = msg.Date[2]
        D = msg.Date[3]
        Mo = msg.Date[4]
        Y = msg.Date[5]
        Status = msg.Date[6]
        Y=Y+2000
        if Status == 0:
            text1 = font1.render(f"{H}:{M}:{S}", True, white)
            text2 = font2.render(f"{D}.{Mo}.{Y}", True, white)
            text_rect1 = text1.get_rect(center=(W/2, Hi/2-150))
            text_rect2 = text2.get_rect(center=(W/2, Hi/2+200))
            win.fill(black)
            win.blit(text1, text_rect1)
            win.blit(text2, text_rect2)
        else:
            text1 = font1.render("Pożar",True, white)
            win.fill(black)
            text_rect1 = text1.get_rect(center=(W/2, Hi/2))
            win.blit(text1, text_rect1)
    pygame.display.update()
    time.sleep(1)
