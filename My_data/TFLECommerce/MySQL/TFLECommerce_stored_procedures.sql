-- use database
use tflecommerce;

-- create a stored procedure (to add data) into user table:-
/*CREATE DEFINER=`root`@`localhost` PROCEDURE `add_user`(
-- Here IN is INPUT and OUT is OUTPUT
	IN p_username VARCHAR(50),
    IN p_password VARCHAR(50),
    IN p_address VARCHAR(100),
    IN p_email VARCHAR (100)
    )
BEGIN
	INSERT into users(username, password, address, email)
    VALUES(p_username, p_password, p_address, p_email);
END */

-- to invoke store procedure:-
CALL add_user('Kaustubh', 'Password10', 'Hanuman Ali- Pen', 'kaustubhpatil@gmail.com');