CREATE TABLE if not exists public.person (
	id serial PRIMARY KEY,
	first_name VARCHAR ( 80 ) NOT NULL,
	last_name VARCHAR ( 80 ) NOT NULL,
	address VARCHAR ( 100 ) NOT NULL,
	gender VARCHAR(20) NOT NULL 
);