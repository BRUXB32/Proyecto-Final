CREATE USER '@name'@'@location' IDENTIFIED BY '@pass';
GRANT SELECT, INSERT, UPDATE, DELETE  ON kefruta.* TO '@name'@'@location';
FLUSH PRIVILEGES;
