create database gestion_stock
use gestion_stock


drop database gestion_stock
--5-------------------------
drop table ventes
create table ventes ( 
Num_ventes int primary key,
ID_art varchar(50) references article (ID_art),
ID_cat varchar(50) references categories(ID_cat) ,
ID_mag varchar(50) references magasin (ID_mag) ,
qtte int 
)
--4-------------------------
select * from article
create table article(
ID_art varchar(50) primary key,
ID_mag varchar(50) references magasin (ID_mag) ,
ID_cat varchar(50) references categories(ID_cat),
qtte_min int ,
qtte_stock int 
)
--2--------------------------
create table categories (
ID_cat varchar(50) primary key,
design_cat varchar (20)
)
--1-------------------------
create table magasin (
ID_mag varchar(50) primary key,
design_mgs varchar(20)
)
---6--------------------------
select * from achats
create table achats (
Num_achat int primary key ,
ID_art varchar(50) references article (ID_art),
ID_cat varchar(50) references categories(ID_cat),
ID_mag varchar(50) references magasin (ID_mag) ,
qtte int ,
)
-----8-----------------------------
create table prevision (
numprv int primary key,
ID_art varchar(50) references article (ID_art),
ID_mag varchar(50) references magasin (ID_mag) ,
ID_cat varchar(50) references categories(ID_cat),
qtte_finale int ,--(entrer par lutilisateur)
qtteprv int ,--(qtte_inital-qtte_finale)
qtte_non_paye int ,--(qtteprv-qttevendue  dans la table ventes )
desc_non_paye varchar(100),--perd--avec ticket--sans ticket--divert 

)

---7------------------------------
drop table commande
create table commande_achats (
Num_cmd int primary key ,
ID_four varchar(50) references fournisseur (ID_four),
Num_achat   int unique references achats (Num_achat),
)
----------------
drop table commande_ventes
create table commande_ventes (
Num_cmd int primary key ,
ID_client varchar(50) references clients (ID_client),
num_ventes    int unique references ventes (num_ventes)
)
---3--------------------------------
create table fournisseur (
ID_four varchar(50) primary key ,
design_four varchar(20),
ville varchar(20)
) 
--9---------------------------------
create table clients (
ID_client varchar(50) primary key, 
design_client varchar(20),
ville varchar(20)
)
update fournisseur set  design_four='ghjkl',ville='ghjjh' where ID_four =2 



insert into fournisseur values (1,'fornisseur1','casa'),
                             (2,'fornisseur2','rabat'),
							 (3,'fornisseur3','tanger'),
							 (4,'fornisseur4','casa')
                            
insert into commande_achats values (1,'1',1),
                             (2,'2',2),
							 (3,'1',3),
							 (4,'4',4)

insert into commande_ventes values (1,'1',1),
                             (2,'2',2),
							 (3,'1',3),
							 (4,'2',4)
							 
 insert into magasin values (1,'magasin1'),
                             (2,'magasin2'),
							 (3,'magasin3'),
							 (4,'magasin4')


insert into categories values (1,'cat1'),
                             (2,'cat2'),
							 (3,'cat3'),
							 (4,'cat4')


insert into article values (1,'1','2',3,20),
                             (2,'2','1',2,26),
							 (3,'3','1',5,55),
							 (4,'1','4',5,47)
select * from article

insert into ventes values (9,'1','1','1',10),
                             (2,'2','1','2',6),
							 (3,'3','1','2',15),
							 (4,'1','4','4',37)

 insert into achats values (1,'2','4','3',10),
                             (2,'3','1','2',6),
							 (3,'4','2','2',15),
							 (4,'1','4','4',37)

insert into prevision values ('1','2',10),
                             ('2','1',2),
							 ('3','1',5),
		     				 ('1','4',7)
insert into clients values ('1','OCP','casa'),
                           ('2','ciment','rabat'),
						   ('3','eps','lisasfa')





update article set id_mag ='3', id_cat='3',qtte_min=2,qtte_stock=2 where ID_art= '1'
  
--prevission trg ---- pour calcule auto--
Select id_art,id_cat, sum(qtte ) as 'qtte vendue'
from ventes 
group by id_art, id_cat

---prevision trg --qtte initial
select id_mag,id_art,id_cat,sum(qtte_stock ) as 'qtte initiale'
from article
group by id_mag,id_art, id_cat



select Qtte from ventes where ID_art='2' and ID_mag='2' 
select qtte_stock from article where ID_mag='1' and ID_art='1'

select  from prevision 

insert into commande (Num_cmd,ID_four) values (8,'1')






/*create trigger trg_prv
on ventes  
for insert 
as begin 
declare @id_art varchar(50) ,@qtte int 
 select @id_art =  id_art from ventes
 select @qtte = qtte from inserted
 set qtte from prevision =
 Select sum(@qtte ) as 'qtte vendue'
from ventes 
group by @id_art
end




 
 select Num_cmd,ID_client,c.Num_ventes,ID_art,ID_cat,ID_mag,qtte from commande_ventes c join  ventes a on c.Num_ventes=a.Num_ventes

 
 select * from achats c join  achats a on c.Num_achat=a.Num_achat*/


 select ID_art,a.ID_mag,design_mgs,a.ID_cat,design_cat,qtte_min,qtte_stock from article a join magasin m on m.ID_mag=a.ID_mag join categories c on  a.ID_cat=c.ID_cat where a.ID_mag=1


 drop trigger trg_cmd
 create trigger trg_cmd
on ventes  
for insert                           
as begin 
declare @check bit 
if((select ID_art from inserted)  in (select ID_art from article ) and (select ID_mag from inserted)  in (select ID_mag from article ) and (select ID_cat from inserted)  in (select ID_cat from article )  )
  begin
set  @check = 1
 update article set qtte_stock -=  (select qtte from inserted) where ID_art= (select ID_art from inserted) and ID_cat=(select ID_cat from inserted)  and  ID_mag = (select ID_mag from inserted)
  end 

else if ((select qtte from inserted) > (select qtte_stock from article))
begin
 set  @check = 0 
end 
 end 

 begin  tran 
 begin try 



select * from ventes  --------------------------------------------------------------------------------


create trigger trg_prv
on prevision  
for insert                           
as begin 
  
   update prevision set qtteprv = (select qtte_stock from article where ID_art =  (select ID_art from inserted)  and  ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted))- (select qtte_finale from inserted  ) where  ID_art =  (select ID_art from inserted)and ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted)
   if ((select ID_art from inserted) not in (select ID_art from ventes ) )
   begin
        update prevision set qtte_non_paye =(select qtteprv from prevision where ID_art =  (select ID_art from inserted) and ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted)) where ID_art =  (select ID_art from inserted) and ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted)
  end 
  else
  begin 
     update prevision set qtte_non_paye =(select qtteprv from prevision where ID_art =  (select ID_art from inserted) and ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted))-(select sum(qtte) from ventes where ID_art = (select ID_art from inserted) and ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted) ) where ID_art =  (select ID_art from inserted) and ID_mag =  (select ID_mag from inserted) and  ID_cat =  (select ID_cat from inserted)

  end 
end

