package bms.stream.sender.util;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-01
 */
public final class Utilities {

    private Utilities() {

    }

    public static double generateRandomValue(double min, double max) {
        return (Math.random() * ((max - min) + 1)) + min;
    }

}
