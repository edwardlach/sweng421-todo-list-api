CREATE TABLE users (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    firstName varchar(100) NOT NULL,
    lastName varchar(100) NOT NULL,
    email varchar(100) NOT NULL,
    password varchar(100) NOT NULL,
    primary key (id)
)