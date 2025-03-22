class Map
{
    field List botsMap;
    field List bricksMap;
    field List bulletsMap;

    constructor List new()
    {
        let botsMap = null;
        let bricksMap = null;
        let bulletsMap = null;
        return this;
    }

    method void addNewBot(Bot bot) {
        let botsMap = List.new(bot, botsMap);
        return;
    }

    method void addNewBrick(Brick brick) {
        let bricksMap = List.new(brick, bricksMap);
        return;
    }

    method void addNewBullet(Bullet bullet) {
        let bulletsMap = List.new(bullet, bulletsMap);
        return;
    }

    method void dispose()
    {
        do Memory.deAAlloc(this);
        return;
    }
}