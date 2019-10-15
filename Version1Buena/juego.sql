-- Creamos la base de datos:
	DROP DATABASE IF EXISTS juego;
	CREATE DATABASE juego;
-- Entramos en la base de datos
	USE juego;
-- Creamos las tablas
	
CREATE TABLE jugador (
	username VARCHAR (20) PRIMARY KEY NOT NULL, 
	password VARCHAR (20) NOT NULL, 
	puntos INTEGER NOT NULL, 
	partidas INTEGER NOT NULL, 
	ganadas INTEGER NOT NULL) ENGINE = InnoDB;

CREATE TABLE partida (
	idpartida INTEGER PRIMARY KEY NOT NULL, 
	ganador VARCHAR (20) NOT NULL, 
	fecha DATE NOT NULL, 
	horain TIME NOT NULL, 
	horafin TIME NOT NULL,
	duracion TIME NOT NULL ) ENGINE = InnoDB;

CREATE TABLE relacion ( 
	idpartida INTEGER not null, 
	foreign key(idpartida) references partida(idpartida),
	username VARCHAR (20) not null,
	foreign key(username) references jugador(username),
	puntuacion INTEGER NOT NULL  ) ENGINE = InnoDB;

-- Insertamos valores en las tablas
INSERT INTO jugador (username, password, puntos, partidas, ganadas) VALUES ('laura', 1234, 21, 6, 1);
INSERT INTO jugador (username, password, puntos, partidas, ganadas) VALUES ('paula', 1111, 42, 8, 2);
INSERT INTO jugador (username, password, puntos, partidas, ganadas) VALUES ('lucas', 2222, 21, 7, 1);
INSERT INTO jugador (username, password, puntos, partidas, ganadas) VALUES ('hugo', 3333, 0, 4, 0);
INSERT INTO jugador (username, password, puntos, partidas, ganadas) VALUES ('flor', 4444, 84, 5, 4);

INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (1,'laura','2018-07-08','11:40:40','12:00:40','00:20:00');
INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (2,'hugo','2018-07-08','14:30:40','15:00:40','00:30:00');
INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (3,'flor','2018-07-08','15:30:40','15:40:40','00:10:00');
INSERT INTO partida (idpartida, ganador, fecha, horain, horafin, duracion)
	VALUES (4,'lucas','2018-07-08','12:25:40','12:32:40','00:07:00');

INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (1,'laura',320);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (1,'hugo',99);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (1,'paula',5);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (2,'lucas',200);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (2,'laura',10);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (2,'paula',20);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (2,'hugo',290);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (3,'laura',50);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (3,'hugo',190);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (3,'flor',310);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (3,'paula',99);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (4,'hugo',160);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (4,'lucas',120);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (4,'flor',99);
INSERT INTO relacion (idpartida, username, puntuacion)
	VALUES (4,'laura',280);
