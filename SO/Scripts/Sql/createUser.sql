CREATE USER '@name'@'@location' IDENTIFIED BY '@pass';
GRANT ALL PIVILEGES ON *.* TO '@name'@'@location';
FLUSH PRIVILEGES;
