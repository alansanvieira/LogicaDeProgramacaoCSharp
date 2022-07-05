create database Escola;

create table instituicao (Id int primary key identity,Nome varchar(100) not null,Endereço varchar(300) not null,CNPJ int not null);create table aluno (Id int primary key identity,id_instituicao int not null,Nome varchar(100) not null,Sobrenome varchar(100) not null,Matricula int not null,constraint FK_instituicao_alunoforeign key (id_instituicao) references instituicao(Id));
