
use Projekt3_Gruppe6;


select * from Country;

select * from Entertainment;
  
select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;
select * from Entertainment, Series where Series.entertainment_id = Entertainment.id;

use master;