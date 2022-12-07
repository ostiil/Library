use master;
create database library;
use library;

--�������� ������
create table users (id_user numeric(5) primary key not null,
					fio char(50),
					login_user char(20) not null unique,
					password_user char(20) not null unique);

create table books(id_book numeric(5) primary key not null,
					name_book char(50) not null,
					autor char(50),
					year_of_public date,
					quantity numeric(5));

create table readers (id_readers numeric(5) primary key not null,
						fio char(50),
						age numeric(3));
alter table readers add history_id numeric(5) foreign key references history(id_history);
create table history (id_history numeric(5) primary key not null,
						readers_id numeric(5) foreign key references readers(id_readers),
						book_id numeric(5) foreign key references books(id_book),
						state char(10));
ALTER TABLE history
ADD CONSTRAINT FK__readershistory foreign key (readers_id)  references readers(id_readers) ;

ALTER TABLE readers
DROP CONSTRAINT FK__readers__history__4316F928;

ALTER TABLE books
ALTER COLUMN year_of_public CHAR(50) NULL;

SELECT name
FROM sys.foreign_keys
WHERE parent_object_id = OBJECT_ID('readers')
AND referenced_object_id = OBJECT_ID('history')

--���������� ������
insert into users (id_user, fio, login_user, password_user) values(1, '������� �������', 'petrova1', '12345');
insert into users (id_user, fio, login_user, password_user) values(2, '���������� �����', 'olna_i', '54321');

insert into books(id_book, name_book, autor, year_of_public, quantity) values (1, '����� ������ � ����� ��������', '����� �������', '2006', 5);
insert into books(id_book, name_book, autor, year_of_public, quantity) values (2, '����� ������ � ����� �������', '����� �������', '2007', 3);

insert into readers(id_readers, fio, age ) values (1, '������ ����', 15);
insert into readers(id_readers, fio, age ) values (2, '������� ����', 13);
insert into readers(id_readers, fio, age ) values (3, '�������� ���������', 17);
insert into readers(id_readers, fio, age ) values (4, '�������� ������', 15);

insert into history (id_history, readers_id, book_id) values (1, 1,1);
insert into history (id_history, readers_id, book_id) values (2, 2,2);
insert into history (id_history, readers_id, book_id) values (3, 3, 2);
insert into history (id_history, readers_id, book_id) values (4, 4,2);