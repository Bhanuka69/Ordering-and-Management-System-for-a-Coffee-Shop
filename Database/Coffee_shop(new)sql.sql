create database Coffee_Shop;
use  Coffee_Shop;

create table Employee(E_ID varchar(10) primary key constraint Emp_Id check(E_ID like 'C%') ,Fname varchar(10),
Lname varchar(20) , TP int ,username varchar(15),PW varchar (10), Town varchar (15),District varchar (15), Block varchar(15),
Street varchar (15) ,Work_Role varchar (10));


insert into Employee values('C0002','Bhanuka','panipitiya',0767650127,'biwa001','0123ab','Homagama','colombo','77','Silver garden','Admin') ,
('C0003' , 'Nisila' , 'Bambarenda' , 0714946911, 'nis01' , '1234' , 'Boralesgamuwa' , 'colombo' , '75' , 'Silver garden' , 'Accountant') ,
('C0004' , 'Sachith' , 'Amaranayake' , 0751234589 , 'sac02' , '789' , 'Piliyandala' , 'Colombo' , '79' , ' Silver garden' , 'Accountant') ,
('C0005' , 'Senadi' , 'Medis' , 0785614521 , 'sen12' , '4561' , 'Nugegoda' , 'Colombo' , '80' , ' Silver garden' , 'Cashier') ,
('C0006' , 'Shinan' , 'Akmal' , 0715641237 , 'Shi235' , 'sh123' , ' Awissawella' , 'Colombo' , '80' , 'Silver garden' ,'Cashier') ;


create table Customer(P_no int primary key constraint Phone_no check (P_no  like '0_________' ),username varchar (20),
PW varchar (10), Fname varchar(10) , Lname varchar (15) ,Bno varchar (10),
Town varchar (15) ,District varchar (15),Street varchar (15));
select * from Customer;

create table Product(P_ID varchar (10) primary key constraint Product_Id check (P_ID like 'P%'),
price decimal (4,2),description varchar (100));
insert into Product values('PR001' , 650.00 , 'a hot, frothy drink with a creamy top, milky middle, and full-bodied brew at the bottom') ,
('PL001' , 700.00 , 'a hot, frothy drink with a creamy top, milky middle, and full-bodied brew at the bottom') ,
('PR002' , 750.00 , 'a chocolate-flavoured warm beverage that is a variant of a café latte') ,
('PL002' , 800.00 , 'a chocolate-flavoured warm beverage that is a variant of a café latte') ,
('PR003' , 700.00 , 'a shot or two of bold, tasty espresso with fresh, sweet steamed milk over it') ,
('PL003' , 750.00 , 'a shot or two of bold, tasty espresso with fresh, sweet steamed milk over it') ,
('PR004' , 750.00 , 'a coffee drink that contains espresso coffee, steamed and frothed milk, and caramel sauce') ,
('PL004' , 800.00 , 'a coffee drink that contains espresso coffee, steamed and frothed milk, and caramel sauce') ,
('PR005' , 500.00 , ' a coffee drink that contains espresso coffee, steamed and frothed milk, and caramel sauce') ,
('PL005' , 600.00 , ' a coffee drink that contains espresso coffee, steamed and frothed milk, and caramel sauce') ,
('PD006' , 400.00 , 'baked cheesecake that is relatively fluffier in its texture compared to several other types of cheesecakes') ,
('PD007' , 450.00 , 'creamy Oreo cheesecake is chock full of those delicious cookies, covered in a beautiful swirled chocolate ganache and crowned with whipped cream') ,
('PD008' , 500.00 , 'We used bars of 60% Ghirardelli chocolate, but you could use bittersweet, milk chocolate, or even a combination of different flavors') ,
('PS009' , 500.00 , 'This cheesy, deep-dish, vegetarian quiche is loaded with onion, bell pepper, mushroom, and zucchin') ,
('PS010' , 400.00 , 'prepared by layering egg, mayonnaise, chicken and cheddar cheese on a pie shell') ,
('PS011' , 450.00 , ' Quiche Lorraine is a combination of a delicious flaky Pie Crust that is filled with savory egg custard') ,
('PS012' , 300.00 , 'Delicious and crispy puff pastry loaded with spiced tuna and vegetables') ,
('PS013' , 500.00 , ' Delicious and crispy puff pastry loaded with mushrooms and vegetables') ,
('PL014' , 700.00 , 'Poached chicken, bouillon, cream cheese and mozzarella make a fabulously creamy stuffing for this rich lasagna' ) ,
('PL015' , 800.00 , 'This meatless lasagna recipe is packed with bell pepper, zucchini and carrots, sautéed until golden on the edges') ,
('PP016' , 900.00 , 'A flavorful Indian-inspired pizza topped with with tandoori mayo, paneer, capsicum and onion. ') ,
('PP017' , 850.00 , 'typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt, and extra-virgin olive oil.' ) ,
('PP018' , 900.00 , 'This Italian cuisine is added with finely sliced chicken sausages, grated mozzarella cheese and pizza sauce') ,
('PP019' , 950.00 , 'Roasted Pepper Pizza with Arrabbiata Sauce is a delicious, pizzeria style pie') ;


select *from Product;
alter table Product
alter column price decimal(5 , 2)


create table Order_table(O_Id varchar (10) primary key constraint order_id check(O_Id like 'O%') ,
ord_date date,phone_no int references customer(P_no));
select * from Order_table;



create table recipt(Recipt_ID varchar (10) primary key constraint r_id check (Recipt_ID like 'R%'),
order_ID varchar (10) references Order_table(O_Id));
select * from recipt;

create table manage (pno int references customer(P_No), 
Eno varchar(10) references Employee(E_ID) primary key (pno,Eno));
select * from manage;

create table product_order(pro_id varchar (10) references Product(P_ID),
Order_ID  varchar (10) references Order_table(O_Id), 
Quantity int primary key (pro_id,Order_ID) );





select*from Employee ; 

