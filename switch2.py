import RPi.GPIO as GPIO
import time
import urllib.request

GPIO.setmode(GPIO.BCM)

GPIO.setup(18, GPIO.IN, pull_up_down=GPIO.PUD_UP)
GPIO.setup(25, GPIO.IN, pull_up_down=GPIO.PUD_UP)


"button counters. i for north (red). j for south (green)"
i = 1
j = 1


while True:
	north_input_state = GPIO.input(18)
	south_input_state = GPIO.input(25)
	print ('reaching here1')
	if north_input_state == False:
		print('North button Pressed', i)
		req = urllib.request.urlopen("https://esmasdbfunction.azurewebsites.net/api/ReceiveButtonPress?code=wpyZrwK2PSj2LMp8tYapfE5Z7dKvgcdKkb4Hy5tt7DlQAaqrHq7ATw==&name=north")
		print ('reaching here4')
		time.sleep(0.2)
		i = i+1
	if south_input_state == False:
		print('South button Pressed', j)
		print('reaching here5')
		req = urllib.request.urlopen("https://esmasdbfunction.azurewebsites.net/api/ReceiveButtonPress?code=wpyZrwK2PSj2LMp8tYapfE5Z7dKvgcdKkb4Hy5tt7DlQAaqrHq7ATw==&name=south")
		print('reaching here6')
		time.sleep(0.2)
		j = j+1

