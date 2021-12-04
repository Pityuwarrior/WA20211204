--create database zoldseges;
--use zoldseges;

create table zoldseg(
id int primary key identity,
nev varchar(50),
egysegAr int);
 
create table eladas(
id int primary key identity,
datum date,
zoldseg int foreign key references zoldseg(id),
mennyiseg int);

insert into zoldseg values
('eper', 2600),
('bab', 1000),
('dinnye', 120),
('cékla', 250);

INSERT INTO eladas VALUES
('2019-12-20', 1, 1),
('2019-12-21', 2, 3),
('2019-12-23', 2, 6),
('2019-12-23', 2, 4),
('2019-01-05', 3, 7),
('2019-01-05', 4, 2),
('2019-01-06', 4, 4);