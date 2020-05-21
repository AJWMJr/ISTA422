insert into _User(UserId, Username, Email)
values (1, 'User1', 'user1@mail.com');

insert into _User(UserId, Username, Email)
values (2, 'User2', 'user2@mail.com');

insert into _User(UserId, Username, Email)
values (3, 'User3', 'user3@mail.com');

insert into Video(VideoId, UserId, Source)
values (1, 1, '/Videos/Vid1.mp4');

insert into Video(VideoId, UserId, Source)
values (2, 2, '/Videos/Vid2.mp4');

insert into Video(VideoId, UserId, Source)
values (3, 3, '/Videos/Vid3.mp4');

insert into Comment(CommentId, VideoId, UserId, Body)
values (1, 2, 1, 'User1 comments on User2''s video');

insert into Comment(CommentId, VideoId, UserId, Body)
values (2, 3, 2, 'User2 comments on User3''s video');

insert into Comment(CommentId, VideoId, UserId, Body)
values (3, 1, 3, 'User3 comments on User1''s video');