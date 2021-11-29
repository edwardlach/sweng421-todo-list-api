CREATE TABLE changes (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    field varchar(50) NOT NULL,
    value varchar(250) NOT NULL,
    `changer` int,
    `task` int NOT NULL,
    `list` int NOT NULL,
    primary key (id),
    foreign key (`list`) references lists (id),
    foreign key (`task`) references tasks (id),
    foreign key (`changer`) references users (id)
)