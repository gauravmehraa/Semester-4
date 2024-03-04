import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BOARD)
pins = [31, 33, 35, 37]

for pin in pins:
	GPIO.setup(pin, GPIO.OUT)
	GPIO.output(pin, False)

def steps(values):
	for i in range(len(pins)):
		GPIO.output(pins[i], values[i])


def rotate(direction, delay, n):
	print("Starting...")
	temp = [[1,0,0,0], [1,1,0,0],[0,1,0,0],[0,1,1,0],[0,0,1,0],[0,0,1,1],[0,0,0,1],[1,0,0,1]]

	if direction == 'A':
		temp = temp[::-1]

	for i in range(n):
		for vals in temp:
			steps(vals)
			time.sleep(delay)

	print("Stopping...")

try:
	while 1:
		delay = float(input("Enter delay: "))/1000.0
		clk = int(input("Steps: "))
		direction = input("Enter direction: ")[:1]
		rotate(direction, delay, clk)
		print()
finally:
	GPIO.cleanup()
