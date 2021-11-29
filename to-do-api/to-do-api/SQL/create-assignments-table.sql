CREATE TABLE assignments (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    deleted boolean NOT NULL,
    `task` int NOT NULL,
    `user` int NOT NULL,
    primary key (id),
    foreign key (`user`) references users (id),
    foreign key (`task`) references tasks (id)
)