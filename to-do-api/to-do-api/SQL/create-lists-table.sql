CREATE TABLE lists (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    name varchar(100) NOT NULL,
    `creator` int,
    primary key (id),
    foreign key (`creator`) references users (id)
)