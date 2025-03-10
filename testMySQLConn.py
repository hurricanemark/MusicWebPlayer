#!/usr/bin/python 
print ("Content-type:text/html\n\n" )
import MySQLdb 

try: 
 conn = MySQLdb.connect (
  host = "aescl1.veriomysql.com", 
  user = "markn", 
  passwd = "*password*", 
  db = "marktest") 

except (MySQLdb.Error, e): 
 print ("Error %d: %s" % (e.args[0], e.args[1]) )
 sys.exit (1) 

print ("connected to the database")