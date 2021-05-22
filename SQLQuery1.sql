create table OvociAndFrukti (
[id] int not null primary key identity,
[Name] nvarchar(50) not null unique,
[Type] Char(1) not null,
[Color] nvarchar(50) not null,
[Collories] int not null,
)