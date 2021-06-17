CREATE TABLE if not exists public.users (
	id serial PRIMARY KEY,
	user_name VARCHAR ( 50 ) NOT NULL unique,
	password VARCHAR ( 130 ) NOT NULL,
	full_name VARCHAR ( 120 ) NOT NULL,
	refresh_token VARCHAR ( 500 ) NULL,
	refresh_token_expiry_time TIMESTAMP NULL
);