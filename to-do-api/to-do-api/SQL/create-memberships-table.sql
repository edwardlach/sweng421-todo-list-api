CREATE TABLE memberships (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    deleted boolean NOT NULL,
    `list` int NOT NULL,
    `user` int NOT NULL,
    primary key (id),
    foreign key (`user`) references users (id),
    foreign key (`list`) references lists (id)
)