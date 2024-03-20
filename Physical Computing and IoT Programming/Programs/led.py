import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)

led = [26, 16, 25, 24, 23, 17, 27, 22] # GPIO Pin Numbers
for light in led:
	GPIO.setup(light, GPIO.OUT)

try:
	while True:
		for light in led:
				print(f"LED {light} ON")
				GPIO.output(light, GPIO.HIGH)
				time.sleep(0.02)
				print(f"LED {light} OFF")
				GPIO.output(light, GPIO.LOW)
				time.sleep(0.02)
finally:
	for light in led:
		GPIO.output(light, GPIO.LOW)