CREATE TABLE if not exists public.books (
	id serial PRIMARY KEY,
	author VARCHAR ( 255 ),
	launch_date TIMESTAMP ( 6 ) NOT NULL,
	price DECIMAL ( 65,2 ) NOT NULL,
	title VARCHAR( 255 )
);