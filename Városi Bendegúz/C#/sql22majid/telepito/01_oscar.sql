DROP DATABASE IF EXISTS oscar;
CREATE DATABASE oscar;
use oscar;

CREATE TABLE film (
	id INT,
	ev INT,
	nyert TINYINT,
	magyar VARCHAR(30),
	cim VARCHAR(30),
	bemutato DATE,
	PRIMARY KEY (id)
);


CREATE TABLE keszito (
	id INT,
	nev VARCHAR(30),
	producer TINYINT,
	PRIMARY KEY (id)
);


CREATE TABLE kapcsolat (
	filmid INT,
	keszitoid INT,
	FOREIGN KEY (filmid) REFERENCES film (id),
	FOREIGN KEY (keszitoid) REFERENCES keszito (id)
);