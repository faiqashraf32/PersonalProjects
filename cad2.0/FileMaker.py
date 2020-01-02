# Python program to explain shutil.move() method  
      
# importing os module  
import os  
  
# importing shutil module  
import shutil  
  
# path  
path = 'C:/Users/faiqe/OneDrive/Desktop'
  
# List files and directories  
# in 'C:/Users/Rajnish/Desktop/GeeksforGeeks'  
print("Before moving file:")  
print(os.listdir(path))  
  
  
# Source path  
source = 'C:/Users/faiqe/OneDrive/Desktop/cad2.0'
  
# Destination path  
destination = 'C:/Users/faiqe/OneDrive/Desktop/cad2.0/files/cars'
  
# Move the content of  
# source to destination 
# using shutil.copytree() as parameter 
dest = shutil.move(source, destination, copy_function = shutil.copytree)  
  
# List files and directories  
# in "C:/Users / Rajnish / Desktop / GeeksforGeeks"  
print("After moving file:")  
print(os.listdir(path))  
  
# Print path of newly  
# created file  
print("Destination path:", dest)  