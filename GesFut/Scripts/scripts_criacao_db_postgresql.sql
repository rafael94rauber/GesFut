create database gesfut;

create table usuario (codigo_usuario bigserial primary key, 
                      nome varchar(100),
					  cpf varchar(11),
 					  data_nascimento date, 
 					  email varchar(100),
 					  endereco varchar(200),
 					  telefone varchar(20),
 					  RG varchar(20),
 					  usuario varchar(30),
 					  senha varchar(100));


create table atleta (codigo_atleta bigserial primary key,
					 nome varchar(100),
					 cpf varchar(11),
					 data_nascimento date,
					  telefone text,
					  sexo text,
					  endereco text,
					  email text
					 );
					 
create table avaliacao_desempenho (codigo_avaliacao bigserial primary key,
								   codigo_atleta bigint,
								   data_avaliacao date,
								   usuario_responsavel bigint,
								   peso double precision,
								   tempo_jogo time,
								   percentual_gordura double precision,
								   velocidade_media double precision,
								   constraint fk_avaliacao_desempenho_atleta foreign key (codigo_atleta) references atleta(codigo_atleta),
								   constraint fk_avaliacao_desempenho_usuario foreign key (usuario_responsavel) references usuario(codigo_usuario)
								  );

create table avaliacao_medica (codigo_avaliacao bigserial primary key,
							   codigo_atleta bigint,
							   data_avaliacao date,
							   usuario_responsavel bigint,
							   peso double precision,
							   temperatura_corporal double precision,
							   pressao varchar(30),
							   batimentos_cardiacos int,
							   alergias text,
							   lesao char(1),
							   fadiga int,
							   fitness int,
							   constraint fk_avaliacao_medica_atleta foreign key (codigo_atleta) references atleta(codigo_atleta),
							   constraint fk_avaliacao_medica_usuario foreign key (usuario_responsavel) references usuario(codigo_usuario)
							   );

create table jogo (codigo_jogo bigserial primary key, time_rival varchar(100), data_hora timestamp);

