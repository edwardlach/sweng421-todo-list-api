CREATE TABLE subscriptions (
    id int NOT NULL AUTO_INCREMENT,
    createdDate datetime NOT NULL,
    updatedDate datetime NOT NULL,
    deleted boolean NOT NULL,
    `userId` int NOT NULL,
    `listId` int NOT NULL,
    lastAccessed datetime,
    primary key (id),
    foreign key (`userId`) references users (id),
    foreign key (`listId`) references lists(id)
)