package bms.stream.sender.value.fetcher;

import bms.stream.sender.util.Utilities;

/**
 * @author Shrinidhi Muralidhar Karanam on 2021-06-03
 */
public class SOCValueFetcher implements ValueFetcher {

    private static final double MIN = 10;
    private static final double MAX = 90;

    @Override
    public double fetch() {
        return Utilities.generateRandomValue(MIN, MAX);
    }
}
