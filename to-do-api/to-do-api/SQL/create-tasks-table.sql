CREATE TABLE tasks (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    title varchar(100) NOT NULL,
    description varchar(255),
    priority varchar(50),
    status varchar(50),
    dueDate datetime,
    `list` int NOT NULL,
    primary key (id),
    foreign key (`list`) references lists (id)
)